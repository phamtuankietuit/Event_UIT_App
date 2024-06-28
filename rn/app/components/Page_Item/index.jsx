import React from "react"
import { Image, Text, TouchableOpacity, View } from "react-native"
import { FontAwesomeIcon } from "@fortawesome/react-native-fontawesome"
import { faThumbsUp } from "@fortawesome/free-solid-svg-icons"
import { useRouter } from "expo-router"
import PageDetail from "../../(page)/page-detail/[id]"
const Page_Item = ({ item, setLike, role }) => {
  const router = useRouter()
  return (
    <TouchableOpacity
      className=' m-2 flex h-[120px] flex-row items-center rounded-lg bg-white px-1 py-3 pb-2'
      style={{
        shadowColor: "#000",
        shadowOffset: {
          width: 0,
          height: 2,
        },
        shadowOpacity: 0.23,
        shadowRadius: 2.62,

        elevation: 4,
      }}
      onPress={() => {
        router.push({ pathname: "(page)/page-detail/[id]", params: { id: item.id } })
      }}
    >
      <View className='text-wrap flex h-[100%] w-[25%] items-center justify-center'>
        <Image
          source={{ uri: item.avatarUrl ? item.avatarUrl : '' }}
          className='h-[80%] w-[80%] rounded-full bg-white '
        />
      </View>

      <View className='flex h-[100%] w-[50%] justify-between'>
        <View>
          <Text className='text-[15px] font-semibold' numberOfLines={2}>{item.name}</Text>
          <Text className='text-[13px]'>
            {item.totalFollowers}
            <Text> Lượt followers</Text>
          </Text>
        </View>
        <Text className='text-xs' numberOfLines={2}>
          {item.description}
        </Text>


      </View>
      {
        role === 'Student' ? <View className='flex h-[100%] w-[25%] items-center justify-center'>
          {item.isThisStudentFollowed === true ? (
            <TouchableOpacity
              className='flex flex-row rounded-lg bg-slate-200 p-2'
              onPress={() => setLike(item.id, false)}
            >
              <Text className='text-slate-500'>Đã follow</Text>
            </TouchableOpacity>
          ) : (
            <TouchableOpacity
              className='flex flex-row rounded-lg bg-cyan-200 p-2 '
              onPress={() => setLike(item.id, true)}
            >
              <Text className='text-cyan-500'>Follow</Text>
            </TouchableOpacity>
          )}
        </View> : ''
      }

    </TouchableOpacity>
  )
}

export default Page_Item
