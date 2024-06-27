import React, { useState, useEffect } from 'react';
import { SafeAreaView } from "react-native-safe-area-context";
import { Platform, Image, Modal, Text, TouchableOpacity, View } from "react-native";
import logo from "../../assets/images/Logo.png"
import { FontAwesomeIcon } from '@fortawesome/react-native-fontawesome';
import {
  faAngleRight,
  faArrowRightFromBracket,
  faCamera,
  faXmark
} from '@fortawesome/free-solid-svg-icons';
import * as ImagePicker from 'expo-image-picker';
import { useRouter } from "expo-router"
import Input from '../../components/Input';
export default function Profile() {
  const router = useRouter()

  const [openPass, setOpenPass] = useState(false)
  const setClosePass = () => {
    setOpenPass(false)
    setPass('')
    setErrorPass('')
    setNewPass('')
    setErrorNewPass('')
    setPreNewPass('')
    setErrorPreNewPass('')
  }
  //Pass
  const [pass, setPass] = useState('')
  const [errorPass, setErrorPass] = useState('')

  const onChangePass = (value) => {
    setPass(value)
    setErrorPass('')
  }

  //NewPass
  const [newPass, setNewPass] = useState('')
  const [errorNewPass, setErrorNewPass] = useState('')

  const onChangeNewPass = (value) => {
    setNewPass(value)
    setErrorNewPass('')
  }

  //NewPass
  const [preNewPass, setPreNewPass] = useState('')
  const [errorPreNewPass, setErrorPreNewPass] = useState('')

  const onChangePreNewPass = (value) => {
    setPreNewPass(value)
    setErrorPreNewPass('')
  }

  //Image
  const imagePicker = async () => {
    const result = await ImagePicker.launchImageLibraryAsync({
      mediaTypes: ImagePicker.MediaTypeOptions.Images,
      allowsEditing: true,
      aspect: [4, 3],
      quality: 1,
    });

    if (!result.cancelled) {
      console.log(result);
    }
  }

  useEffect(() => {
    (async () => {
      if (Platform.OS !== 'web') {
        const { status } = await ImagePicker.requestMediaLibraryPermissionsAsync();
        if (status !== 'granted') {
          alert('Sorry, we need camera roll permissions to make this work!');
        }
      }
    })();
  }, []);
  return (
    <SafeAreaView className='flex-1'>
      <View className="text-wrap flex items-center flex-row gap-5 px-10">
        <View className='flex flex-row items-end'>
          <Image
            source={logo}
            className="bg-white rounded-full w-[100px] h-[100px] me-4 "
          />
          <TouchableOpacity onPress={() => imagePicker()}>
            <FontAwesomeIcon icon={faCamera} />
          </TouchableOpacity>
        </View>

        <View className='me-3'>
          <Text className='font-semibold mb-2'>Ngô Trung Quân</Text>
          <Text>sinh viên</Text>
        </View>
      </View>

      <View className='px-10 my-7'>
        <TouchableOpacity className='rounded-xl w-[100%] bg-blue-500 p-4 mb-3 flex justify-between flex-row items-center' onPress={() => setOpenPass(true)} style={{
          shadowColor: "#000",
          shadowOffset: {
            width: 0,
            height: 2,
          },
          shadowOpacity: 0.23,
          shadowRadius: 2.62,

          elevation: 4,
        }}>
          <Text className='text-white'>Đổi mật khẩu</Text>
          <FontAwesomeIcon icon={faAngleRight} color='white' />
        </TouchableOpacity>
        <TouchableOpacity className='rounded-xl w-[100%] bg-blue-500 p-4 mb-3 flex justify-between flex-row items-center' onPress={() => router.navigate("/(page)/Participation_Event/participation_event")} style={{
          shadowColor: "#000",
          shadowOffset: {
            width: 0,
            height: 2,
          },
          shadowOpacity: 0.23,
          shadowRadius: 2.62,

          elevation: 4,
        }}>
          <Text className='text-white'>Quản lý sự kiện tham gia</Text>
          <FontAwesomeIcon icon={faAngleRight} color='white' />
        </TouchableOpacity>
        <TouchableOpacity className='rounded-xl w-[100%] bg-blue-500 p-4 mb-3 flex justify-between flex-row items-center' onPress={() => router.navigate("/(page)/Student_History/student_history")} style={{
          shadowColor: "#000",
          shadowOffset: {
            width: 0,
            height: 2,
          },
          shadowOpacity: 0.23,
          shadowRadius: 2.62,

          elevation: 4,
        }}>
          <Text className='text-white'>Điểm rèn luyện</Text>
          <FontAwesomeIcon icon={faAngleRight} color='white' />
        </TouchableOpacity>
        <TouchableOpacity className='rounded-xl w-[100%] bg-blue-500 p-4 mb-3 flex justify-between flex-row items-center' onPress={() => router.navigate("/(page)/Management_Event/management_event")} style={{
          shadowColor: "#000",
          shadowOffset: {
            width: 0,
            height: 2,
          },
          shadowOpacity: 0.23,
          shadowRadius: 2.62,

          elevation: 4,
        }}>
          <Text className='text-white'>Quản lý sự kiện</Text>
          <FontAwesomeIcon icon={faAngleRight} color='white' />
        </TouchableOpacity>
        <TouchableOpacity className='rounded-xl w-[100%] bg-blue-500 p-4 mb-3 flex justify-between flex-row items-center' style={{
          shadowColor: "#000",
          shadowOffset: {
            width: 0,
            height: 2,
          },
          shadowOpacity: 0.23,
          shadowRadius: 2.62,

          elevation: 4,
        }}>
          <Text className='text-white'>Báo cáo thống kê</Text>
          <FontAwesomeIcon icon={faAngleRight} color='white' />
        </TouchableOpacity>
        <TouchableOpacity className='rounded-xl w-[100%] bg-blue-500 p-4 mb-3 flex justify-between flex-row items-center' style={{
          shadowColor: "#000",
          shadowOffset: {
            width: 0,
            height: 2,
          },
          shadowOpacity: 0.23,
          shadowRadius: 2.62,

          elevation: 4,
        }}>
          <Text className='text-white'>Đăng xuất</Text>
          <FontAwesomeIcon icon={faArrowRightFromBracket} color='white' />
        </TouchableOpacity>

      </View>
      <Modal
        visible={openPass}
        animationType="slide"
        transparent={true}
        onRequestClose={() => {
          setClosePass();
        }}
      >
        <SafeAreaView>
          <View className='bg-white h-full p-3'>
            <View className='flex flex-row justify-between h-[5%]'>
              <Text>Đổi mật khẩu</Text>
              <TouchableOpacity onPress={() => setClosePass()} >
                <FontAwesomeIcon icon={faXmark} className='w-[20%]' />
              </TouchableOpacity>

            </View>

            <Input value={pass} handleChange={onChangePass} placeholder={'Nhập mật khẩu'} error={errorPass} title={'Mật khẩu'} require password={true} />
            <Input value={newPass} handleChange={onChangeNewPass} placeholder={'Nhập mật khẩu mới'} error={errorNewPass} title={'Mật khẩu mới'} require password={true} />
            <Input value={preNewPass} handleChange={onChangePreNewPass} placeholder={'Nhập lại mật khẩu mới'} error={errorNewPass} title={'Mật khẩu mới'} require password={true} />

            <View className='flex justify-center items-center my-2'>
              <TouchableOpacity className='rounded-2xl w-[60%] bg-[#3A57E8] py-3 px-3 my-3 flex justify-center items-center'>
                <Text className='text-white'>Đổi mật khẩu</Text>
              </TouchableOpacity>
            </View>

          </View>
        </SafeAreaView>

      </Modal>
    </SafeAreaView>
  );
}
