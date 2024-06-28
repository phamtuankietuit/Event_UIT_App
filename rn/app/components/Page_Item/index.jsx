import React from "react"
import { Image, Text, TouchableOpacity, View } from "react-native"
import { FontAwesomeIcon } from "@fortawesome/react-native-fontawesome"
import { faThumbsUp } from "@fortawesome/free-solid-svg-icons"
import { useRouter } from "expo-router"
const Page_Item = ({ item, setLike }) => {
  const router = useRouter()
  return (
    <TouchableOpacity
      className='m-2 flex h-[110px] w-[98%] flex-row items-center rounded-lg bg-white px-2 py-1 pb-2'
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
        router.push({ pathname: "(page)/page-detail", params: { id: item.id } })
      }}
    >
      <View className='text-wrap flex h-[100%] w-[25%] items-center justify-center'>
        <Image
          source={{ uri: item.avatarUrl ? item.avatarUrl : '' }}
          className='mr-4 h-[95%] w-[95%] rounded-full bg-white '
        />
      </View>

      <View className='flex h-[100%] w-[45%] gap-y-3'>
        <View>
          <Text className='text-[16px] font-semibold'>{item.name}</Text>
          <Text className='text-[13px]'>
            {item.totalFollowers}
            <Text> Lượt followers</Text>
          </Text>
        </View>


        <Text className='text-xs' numberOfLines={2}>
          {item.description}
        </Text>


      </View>
      <View className='flex h-[100%] w-[30%] items-center justify-center'>
        {item.like === true ? (
          <TouchableOpacity
            className='flex flex-row rounded-lg bg-slate-200 p-2'
            onPress={() => setLike(item.id, false)}
          >
            <FontAwesomeIcon icon={faThumbsUp} color='#64748b' />
            <Text className=' text-slate-500 ml-2'>Đã follow</Text>
          </TouchableOpacity>
        ) : (
          <TouchableOpacity
            className='flex flex-row rounded-lg bg-cyan-200 p-2 '
            onPress={() => setLike(item.id, true)}
          >
            <FontAwesomeIcon icon={faThumbsUp} color='#06b6d4' />
            <Text className=' text-cyan-500 ml-2'>Follow</Text>
          </TouchableOpacity>
        )}
      </View>
    </TouchableOpacity>
  )
}

export default Page_Item
